# WEB_BT1
Bài tập 01 của sinh viên: K225480106057 - Phạm Mạnh Quỳnh - môn Lập trình web

BÀI TẬP VỀ NHÀ 01:
TẠO SOLUTION GỒM CÁC PROJECT SAU:

1. DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).
2. Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE
3. Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE
4. Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.

# Bài Làm
- Tên đề tài: KIỂM TRA SỐ CHÍNH PHƯƠNG
- Sử dụng Visual Studio 2022
# 1. CLASS LIB
- Creat a new project ---> Bấm chọn class library (.NET Framework 2.0) và đặt tên: MathLibrary
- Sửa lại tên file class1.cs = NumberChecks.cs và thay code trong đó bằng các input, output, hàm. Nhấn build solution để ra được file maytinhdongian.dll
<img width="1920" height="1080" alt="Screenshot 2025-09-28 170450" src="https://github.com/user-attachments/assets/34dcfeac-600f-4406-bc93-41d853f08333" />
- kết quả:
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/8e85faf3-c90b-4abc-b83f-22fb29bd5de6" />
# 2. CONSOLE APP
- Tạo project console app ( .NET Framework 2.0) thêm Reference tới MathLibrary.dll và sửa lại code trong Program.cs
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/c60e53a1-93bd-4da8-b273-0dd2dbc9ac60" />
- Chuột phải vào project console ---> Set as startup project ---> F5 để chạy console app
- Kết quả:
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/fc446549-01ec-45c1-a43f-4f71f8a7c49f" />
#3. WINDOWS FORM APP
- Tạo project Windows form app ( .NET Framework 2.0) thêm Reference tới MathLibrary.dll.
- Sau khi tạo, có 2 cách để tạo giao diện cho màn hình:
  + Dùng thao tác đồ họa kéo thả các thanh toolbox vào khung
  + Dùng code thay thế cho các file .cs để tự động tạo giao diện
- Ở đây em dùng cách 1: dùng thao tác đồ họa kéo thả các thanh toolbox vào khung:
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/d20384c5-9a8d-44e8-a6e8-d12cca0cb1f1" />
- Tiếp tục project window form app ---> Set as startup project ---> F5 để chạy window form app
- Kết quả:
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/9d3151f3-d4ca-42b6-9a49-4813bbd14213" />
# 4. WEB FORM
- Tạo project ASP.NET Web Application ( .NET Framework 2.0) thêm Reference tới MathLibrary.dll.
- Từ project này add thêm 1 HTML page đặt tên index.html và 1 item tên api.aspx
- Viết code html, css, js cho file index.html và code-behind cho api.aspx.cs
<img width="1920" height="1080" alt="Screenshot 2025-09-28 171958" src="https://github.com/user-attachments/assets/ad8782b3-dda4-48d4-9141-9c651310acf2" />
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/5785d0cf-a7b6-4093-bcc0-3836206d5dcc" />
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/d18d24db-49c9-48b9-be87-3804a1f0d50f" />
- Tạo 1 folder và publish Web Form vào folder đó:
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/8ca58838-f62f-4e73-af19-5d143514198f" />
- Deploy IIS + Host:
  + Mở IIS --> Add Website ---> Trỏ đến folder vừa Publish vào
  + Hostname: kiemtrasocp.com, Port: 80
  + Mở nodepad chay quyền admin và mở tệp hosts trong địa chỉ: C:\Windows\System32\drivers\etc\hosts. Thêm dòng "127.0.0.1 kiemtrasocp.com" vào cuối tệp và lưu lại.
- Kết quả chạy trên localhost với tên miền là kiemtrasocp.com:
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/45da8373-9a3a-4a85-a6bf-b8448e399b80" />
