using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndentifiedFace.Configurations.Language
{
    public class EnglishLanguagePackage : LanguagePackage
    {
        public string getMainFormTitle() { return "Nhận dạng khuôn mặt kết hợp chấm công"; }
        public string getErrorConnectToDatabaseMessage() { return "Không thể kết nối tới CSDL!"; }
        public string getErrorConnectToDatabaseTitle() { return "Lỗi!!";  }
        public string getAskRetryLoginMessage() { return "Đăng nhập lỗi. Vui lòng thử lại."; }
        public string getAskRetryLoginTitle() { return "Đăng nhập";  }
        public string getConfirmQuitApplicationMessage() { return "Bạn có thực sự muốn thoát?"; }
        public string getConfirmQuitApplicationTitle() { return "Thoát ứng dụng"; }
        public string getAuthorName() { return "Kiều Anh Sơn"; }
        public string getLoginFormTitle() { return "Đăng nhập"; }
        public string getLoginButtonLabel() { return "Đăng nhập"; }
        public string getQuitButtonTitle() { return "Thoát"; }
        public string getUsernameInputLabel() { return "Tên đăng nhập"; }
        public string getPasswordInputLabel() { return "Mật khẩu"; }
        public string getLoginFormFontName() { return "Times New Roman"; }
        public string getLoginFormCaption() { return "Đăng nhập~"; }

        public string getMainFormQuitConfimMessage() { return "Bạn có thực sự muốn thoát?"; }
        public string getMainFormQuitConfimTitle() { return "Tắt ứng dụng"; }
        public string getStatusClassLabel() { return "Phòng: "; }
        public string getStatusQuantityLabel() { return "Tổng NV: "; }
        public string getNoDataSelectedWhenDeleteErrorMessage() { return "Vui lòng chọn dữ liệu để xóa!"; }
        public string getNoDataSelectedWhenDeleteErrorTitle() { return "Xóa nhân viên"; }
        public string getMemberCodeAlias() { return "Mã nhân viên"; }
        public string getDeleteMembersButtonLabel() { return "Xóa"; }
        public string getAddMembersButtonLabel() { return "Thêm"; }
        public string getMakingRollCallButtonLabel() { return "Chấm công"; }
        public string getMainFormMenuFileLabel() { return "File"; }
        public string getMainFormMenuFileMemberListLabel() { return "Danh sách nhân viên"; }
        public string getMainFormMenuOperationLabel() { return "Thao tác"; }
        public string getMainFormMenuHelpLabel() { return "Trợ giúp"; }
        public string getMainFormMenuAboutLabel() { return "Thông tin"; }
        public string getLastNameAlias() { return "Họ "; }
        public string getFirstNameAlias() { return "Tên "; }
        public string getMaleAlias() { return "Nam"; }
        public string getFemaleAlias() { return "Nữ"; }
        public string getSexAlias() { return "Giới tính "; }
        public string getBirthAlias() { return "Ngày sinh "; }
        public string getClassAlias() { return "Phòng "; }

        public string getAboutFormFontName() { return "Microsoft Sans Serif"; }
        public string getAboutFormMainCaptionFontName() { return "Times New Roman"; }
        public string getAboutFormMainCaption() { return "Khoa CNTT"; }
        public string getAboutFormTopCaption() { return "Đại học Tài nguyên và Môi trường Hà Nội"; }
        public string getAboutFormSubTopCaption() { return "ENVERGA UNIVERSITY"; }
        public string getAboutFormCenterCaption() { return "DEVELOPMENT OF FACE RECOGNITION TIMEKEEPING SYSTEM AND INTRUSION DETECTION"; }
        public string getAboutFormSubTitle2() { return "BY              :Kiều Anh Sơn"; }
        public string getAboutFormSubTitle1() { return ""; }
        public string getAboutFormTitle() { return "SPECIAL PROJECT"; }

        public string getMakingRollCallSuccessSerialMessage() { return "A"; }
        public string getMakingRollCallFailSerialMessage() { return "B"; }

        public string getMemeberInfoBlockTitle() { return "Thông tin nhân viên"; }
        public string getResetButtonTitle() { return "Reset"; }
        public string getAddMemberFormTitle() { return "Thêm nhân viên"; }
        public string getOperationsBlockTitle() { return "Thao tác"; }

        public string getFaceDetectingBlockTitle() { return "Nhận dạng khuôn mặt"; }
        public string getCameraActionButtonLabel() { return "Camera"; }
        public string getMembersNotMakingRollCallYetTitle() { return "Nhân viên đã được điểm danh!"; }
        public string getMembersAlreadyMakingRollCallTitle() { return "Nhân viên chưa được điểm danh!"; }
        public string getMakingRollCallOperationsBlockTitle() { return "Thao tác"; }
        public string getOutputDeviceSelectionTitle() { return "Thiết bị đầu ra: "; }
        public string getMakingRollCallFormTitle() { return "Chấm công"; }

        public string getMemberNotFoundMessage() { return "Nhân viên không tìm thấy!"; }
        public string getMemberNotFoundLabel() { return "Cảnh báo"; }

    }
}
