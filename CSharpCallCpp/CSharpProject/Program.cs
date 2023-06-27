using System;
using System.Runtime.InteropServices;
using CSharpProject.Types;

namespace CSharpProject
{
    internal class Program
    {
        [DllImport(@"CppProject.dll", EntryPoint = "UpdateCameraSetting", SetLastError = true, 
            CharSet = CharSet.Ansi, ExactSpelling = false, CallingConvention = CallingConvention.StdCall)]
        public static extern void UpdateCameraSetting(Camera camera);

        [DllImport(@"CppProject.dll", EntryPoint = "GetCameraImage", SetLastError = true, 
            CharSet = CharSet.Ansi, ExactSpelling = false, CallingConvention = CallingConvention.StdCall)]
        public static extern void GetCameraImage(ref CameraImageData cameraImageData);

        [DllImport(@"CppProject.dll", EntryPoint = "GetCameraImage2", SetLastError = true,
            CharSet = CharSet.Ansi, ExactSpelling = false, CallingConvention = CallingConvention.StdCall)]
        public static extern void GetCameraImage2(IntPtr image);

        static void Main(string[] args)
        {
            //C# 往 C++ 写数据
            var camera = GenerateCamera();
            UpdateCameraSetting(camera);

            //C++ 往 C# 写数据(值类型）
            var image = new CameraImageData();
            GetCameraImage(ref image);

            //C++ 往 C# 写数据(byte[]）
            var bytes = new byte[3];
            var imagePtr = Marshal.AllocHGlobal(bytes.Length);
            GetCameraImage2(imagePtr);
            Marshal.Copy(imagePtr, bytes, 0, bytes.Length);
            Marshal.FreeHGlobal(imagePtr);
        }

        static Camera GenerateCamera()
        {
            var camera = new Camera();
            camera.CameraId = 1;
            camera.CameraName = "Camera2";
            var innerSetting = new CameraSetting
            {
                Setting1 = 10,
                Setting2 = true,
                Setting3 = "Setting3"
            };
            camera.Setting = innerSetting;

            return camera;
        }

    }
}
