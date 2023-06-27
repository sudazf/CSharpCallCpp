#pragma once

//�������
typedef struct CameraSetting
{
	int Setting1;
	bool Setting2;
	char Setting3[20];
};

//���
typedef struct Camera
{
	int CameraId;
	bool IsActive;
	char CameraName[20];
	CameraSetting Setting;
};

//���ͼƬ
typedef struct CameraImageData
{
public:
	int CameraId;
	char CameraName[20];
	BYTE Image[50000];
	CameraSetting Setting;
};


//д���������
extern "C" _declspec(dllexport)  void __stdcall UpdateCameraSetting(Camera camera);

//��ȡ������ص�ͼƬ
extern "C" _declspec(dllexport)  void __stdcall GetCameraImage(CameraImageData* image);

//��ȡ������ص�ͼƬ2
extern "C" _declspec(dllexport)  void __stdcall GetCameraImage2(BYTE* image);


