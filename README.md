# Quản Lý Bán Hàng Quán Cà Phê
**Lê Trường Giang** - Mã sinh viên: **22010224**

## Giới Thiệu
Ứng dụng **Quản Lý Bán Hàng Quán Cà Phê** là một phần mềm hỗ trợ quản lý hoạt động kinh doanh của quán cà phê, giúp việc theo dõi và xử lý đơn hàng trở nên dễ dàng và hiệu quả hơn.

Ứng dụng  sử dụng công nghệ **WinForms** với ngôn ngữ lập trình **C#** và cơ sở dữ liệu **SQL Server**.

## Tính Năng Chính
- **Tạo hóa đơn**: Thêm các món vào hóa đơn và quản lý trạng thái bàn.
- **Đổi bàn**: Hỗ trợ chuyển bàn khi khách có nhu cầu thay đổi chỗ ngồi.
- **Thanh toán hóa đơn**: Tính tổng tiền và xác nhận thanh toán cho khách hàng.
- **Quản lý doanh thu**: Xem báo cáo doanh thu theo ngày.
- **Quản lý menu**: Thêm, sửa, xóa các món có trong menu của quán.
- **Quản lý tài khoản**: Quản lý thông tin đăng nhập, thêm/sửa/xóa tài khoản nhân viên (không thể xóa tài khoản đang đăng nhập).

## Công Nghệ Sử Dụng
- **Ngôn ngữ lập trình**: C#
- **Giao diện**: Windows Forms (WinForms)
- **Cơ sở dữ liệu**: SQL Server

## Cài Đặt & Sử Dụng
### Yêu Cầu Hệ Thống
- Windows 10/11
- .NET Framework 4.7 trở lên
- SQL Server (bản Express hoặc cao hơn)
- Visual Studio (khuyến nghị bản 2019 trở lên)

### Hướng Dẫn Cài Đặt
1. Clone hoặc tải source code về máy:
   ```sh
   git clone <repo-link>
   ```
2. Mở project bằng Visual Studio.
3. Kết nối cơ sở dữ liệu SQL Server bằng cách chạy file script SQL trong thư mục `Database`.
4. Cấu hình chuỗi kết nối trong `App.config` nếu cần.
5. Build và chạy ứng dụng trên Visual Studio.



