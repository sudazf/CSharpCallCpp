using System.Runtime.InteropServices;

namespace CSharpProject.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Camera
    {
        public int CameraId;
        public bool IsActive;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string CameraName;

        //[MarshalAs(UnmanagedType.Struct, SizeConst = 40)]
        public CameraSetting Setting;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CameraSetting
    {
        public int Setting1;
        public bool Setting2;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string Setting3;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CameraImageData
    {
        public int CameraId;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string CameraName;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50000)]
        public byte[] Image;
        public CameraSetting Setting;
    };


    public class Roi
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Roi()
        {
            
        }

        public Roi(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
    }
}
