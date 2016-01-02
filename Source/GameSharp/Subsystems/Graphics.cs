using System;
using SDL2;
using OpenGL;

namespace GameSharp
{
    public static class Graphics
    {
        private static IntPtr window;

        static string vs =
@"#version 330 core
uniform mat4 projectionMatrix;
in vec3 position;
in vec3 color;
out vec3 fragmentColor;
void main(void)
{
    gl_Position = projectionMatrix * vec4(position, 1.0);
    fragmentColor = color;
}";
                    
        static string fs =
@"#version 330 core
in vec3 fragmentColor;
out vec4 color;
void main(void)
{
    color = vec4(fragmentColor, 1.0);
}";

        static uint shaderProgram;
        static uint[] meshVAO = new uint[1];
        static uint[] meshVBO = new uint[1];
        static int vertexCount = 3;

        static void CheckError(string message, uint shader = 0, uint program = 0)
        {
            var error = Gl.GetError();
            if (error != ErrorCode.NoError)
                Log.WriteLine("Error: " + message + " Code: " +  error.ToString());
            if (shader != 0)
            {
                string shaderLog = Gl.GetShaderInfoLog(shader);
                if (shaderLog.Length > 0)
                    Log.WriteLine("Shader log (" + message + "): " + shaderLog);
            }
            if (program != 0)
            {
                string programLog = Gl.GetProgramInfoLog(shader);
                if (programLog.Length > 0)
                    Log.WriteLine("Program log (" + message + "): " + programLog);
            }
        }
        
        static bool GetShaderCompileStatus(UInt32 shader)
        {
            int[] status = new int[1];
            Gl.GetShaderiv(shader, ShaderParameter.CompileStatus, status);
            return (status[0] > 0);
        }

        public static void Init()
        {
            SDL.SDL_Init(SDL.SDL_INIT_VIDEO);
            SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_CONTEXT_MAJOR_VERSION, 3);
            SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_CONTEXT_MINOR_VERSION, 3);
            window = SDL.SDL_CreateWindow("GameSharp", SDL.SDL_WINDOWPOS_UNDEFINED, SDL.SDL_WINDOWPOS_UNDEFINED, 800, 600, SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN | SDL.SDL_WindowFlags.SDL_WINDOW_OPENGL);
            var glContext = SDL.SDL_GL_CreateContext(window);

            shaderProgram = Gl.CreateProgram();
            if (shaderProgram == 0)
                Log.WriteLine("shaderProgram == 0");

            var vertexShader = Gl.CreateShader(ShaderType.VertexShader);
            if (vertexShader == 0)
                Log.WriteLine("vertexShader == 0");

            var fragmentShader = Gl.CreateShader(ShaderType.FragmentShader);
            if (fragmentShader == 0)
                Log.WriteLine("fragmentShader == 0");

            Gl.ShaderSource(vertexShader, 1, new String[] { vs }, new int[] { vs.Length });
            CheckError("1", vertexShader);
 
            Gl.CompileShader(vertexShader);
            if (!GetShaderCompileStatus(vertexShader))
                Log.WriteLine("vertexShader not compiled");
            CheckError("2", vertexShader);

            Gl.ShaderSource(fragmentShader, 1, new String[] { fs }, new int[] { fs.Length });
            CheckError("3", fragmentShader);

            Gl.CompileShader(fragmentShader);
            if (!GetShaderCompileStatus(fragmentShader))
                Log.WriteLine("fragmentShader not compiled");
            CheckError("4", fragmentShader);

            Gl.AttachShader(shaderProgram, vertexShader);
            CheckError("5", vertexShader);
            
            Gl.AttachShader(shaderProgram, fragmentShader);
            CheckError("6", fragmentShader);
            
            Gl.LinkProgram(shaderProgram);
            CheckError("7"); // not works program log?
            
            int vertexSize = 6 * sizeof(float);
            float[] triangleMesh = {
                -1.0f, -1.0f, -2.0f, 1.0f, 0.0f, 0.0f,
                0.0f,  1.0f, -2.0f, 0.0f, 1.0f, 0.0f,
                1.0f, -1.0f, -2.0f, 0.0f, 0.0f, 1.0f
            };
            
            Gl.GenVertexArrays(1, meshVAO);
            CheckError("8");
            
            Gl.BindVertexArray(meshVAO[0]);
            CheckError("9");

            Gl.GenBuffers(1, meshVBO);
            CheckError("10");
            
            Gl.BindBuffer(BufferTarget.ArrayBuffer, meshVBO[0]);
            CheckError("11");
            
            Gl.BufferData(BufferTarget.ArrayBuffer, vertexCount * vertexSize, triangleMesh, BufferUsageHint.StaticDraw);
            CheckError("12");

            uint vertexOffsetPosition = 0;
            uint vertexOffsetColor = 3 * sizeof(float);

            var positionLocation = Gl.GetAttribLocation(shaderProgram, "position");
            if (positionLocation == -1)
                Log.WriteLine("posinitonLocation == -1");
            
            Gl.VertexAttribPointer((uint)positionLocation, 3, VertexAttribPointerType.Float, false, vertexSize, new IntPtr(vertexOffsetPosition));
            CheckError("13");
            
            Gl.EnableVertexAttribArray((uint)positionLocation);
            CheckError("14");

            var colorLocation = Gl.GetAttribLocation(shaderProgram, "color");
            if (colorLocation == -1)
                Log.WriteLine("colorLocation == -1");

            Gl.VertexAttribPointer((uint)colorLocation, 3, VertexAttribPointerType.Float, false, vertexSize, new IntPtr(vertexOffsetColor));
            CheckError("15");

            Gl.EnableVertexAttribArray((uint)colorLocation);
            CheckError("16");

            float aspectRatio = 800.0f / 600.0f;
            var projectionMatrix = Matrix4Perspective(45.0f, aspectRatio, 0.5f, 5.0f);
            
            var projectionMatrixLocation = Gl.GetUniformLocation(shaderProgram, "projectionMatrix");
            if (projectionMatrixLocation == -1)
                Log.WriteLine("projectionMatrixLocation == -1");
            CheckError("17");
            
            Gl.UseProgram(shaderProgram); // need before UniformMatrix4fv
            CheckError("18");
                
            Gl.UniformMatrix4fv(projectionMatrixLocation, 1, false, projectionMatrix);
            CheckError("19");
         }

         static float[] Matrix4Perspective(float fovy, float aspect, float znear, float zfar)
         {
             float f = (float)(1.0f / Math.Tan(fovy * Math.PI / 180.0f));
             float A = (zfar + znear) / (znear - zfar);
             float B = (2 * zfar * znear) / (znear - zfar);
             return new float[] { f / aspect, 0, 0, 0,
                              0, f, 0, 0,
                              0, 0, A, B,
                              0, 0, -1, 0 };
         }

         public static void Update()
         {
            //Gl.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
            //Gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit );
            //Gl.UseProgram(shaderProgram);
            //Gl.BindVertexArray(meshVAO[0]);
            Gl.DrawArrays(BeginMode.Triangles, 0, vertexCount);
            SDL.SDL_GL_SwapWindow(window);
         }
    }
}
