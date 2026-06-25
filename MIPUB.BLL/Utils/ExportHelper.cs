using System;
using System.Collections.Generic;
using System.IO;
using ClosedXML.Excel;
using MIPUB.Models.Entities;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace MIPUB.BLL.Utils
{
    public class ExportHelper
    {
        public ExportHelper()
        {
            // Yêu cầu bắt buộc của thư viện QuestPDF từ bản 2022.12 trở đi
            QuestPDF.Settings.License = LicenseType.Community;
        }

        public void ExportToExcel(List<Sach> danhSach, string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("DanhSachSach");

                // Tiêu đề cột
                worksheet.Cell(1, 1).Value = "Mã Sách";
                worksheet.Cell(1, 2).Value = "Tiêu Đề";
                worksheet.Cell(1, 3).Value = "Năm XB";
                worksheet.Cell(1, 4).Value = "Tác Giả";
                worksheet.Cell(1, 5).Value = "Loại Sách";
                worksheet.Cell(1, 6).Value = "Chi Tiết Đa Hình";

                // Format Header (In đậm, nền xanh)
                var headerRow = worksheet.Range("A1:F1");
                headerRow.Style.Font.Bold = true;
                headerRow.Style.Fill.BackgroundColor = XLColor.LightBlue;
                headerRow.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                // Đổ dữ liệu
                for (int i = 0; i < danhSach.Count; i++)
                {
                    int row = i + 2;
                    var sach = danhSach[i];
                    worksheet.Cell(row, 1).Value = sach.MaSach;
                    worksheet.Cell(row, 2).Value = sach.TieuDe;
                    worksheet.Cell(row, 3).Value = sach.NamXuatBan;
                    worksheet.Cell(row, 4).Value = sach.TacGia?.HoTen ?? sach.TacGiaId.ToString();
                    worksheet.Cell(row, 5).Value = sach.LoaiSach;
                    worksheet.Cell(row, 6).Value = sach.HienThiThongTin();
                }

                // Tự động căn chỉnh độ rộng cột
                worksheet.Columns().AdjustToContents();

                // Lưu file
                workbook.SaveAs(filePath);
            }
        }

        public void ExportToPdf(List<Sach> danhSach, string filePath)
        {
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4.Landscape());
                    page.Margin(1, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(11).FontFamily(Fonts.Arial)); // Dùng Arial để hỗ trợ Tiếng Việt

                    page.Header().Element(ComposeHeader);
                    page.Content().Element(x => ComposeContent(x, danhSach));
                    page.Footer().AlignCenter().Text(x =>
                    {
                        x.Span("Trang ");
                        x.CurrentPageNumber();
                        x.Span(" / ");
                        x.TotalPages();
                    });
                });
            })
            .GeneratePdf(filePath);
        }

        private void ComposeHeader(IContainer container)
        {
            container.Row(row =>
            {
                row.RelativeItem().Column(column =>
                {
                    column.Item().Text("BÁO CÁO DANH MỤC SÁCH - MIPUB").FontSize(20).SemiBold().FontColor(Colors.Blue.Darken2);
                    column.Item().Text($"Ngày xuất: {DateTime.Now:dd/MM/yyyy HH:mm}").FontSize(10).FontColor(Colors.Grey.Medium);
                });
            });
        }

        private void ComposeContent(IContainer container, List<Sach> danhSach)
        {
            container.PaddingVertical(1, Unit.Centimetre).Table(table =>
            {
                // Định nghĩa cột
                table.ColumnsDefinition(columns =>
                {
                    columns.ConstantColumn(60);  // Mã sách
                    columns.RelativeColumn();    // Tiêu đề
                    columns.ConstantColumn(50);  // Năm XB
                    columns.RelativeColumn();    // Tác giả
                    columns.ConstantColumn(80);  // Loại
                    columns.RelativeColumn(2);   // Chi tiết
                });

                // Header
                table.Header(header =>
                {
                    header.Cell().Element(CellStyle).Text("Mã Sách");
                    header.Cell().Element(CellStyle).Text("Tiêu Đề");
                    header.Cell().Element(CellStyle).Text("Năm XB");
                    header.Cell().Element(CellStyle).Text("Tác Giả");
                    header.Cell().Element(CellStyle).Text("Loại Sách");
                    header.Cell().Element(CellStyle).Text("Chi Tiết");

                    static IContainer CellStyle(IContainer container)
                    {
                        return container.DefaultTextStyle(x => x.SemiBold()).PaddingVertical(5).BorderBottom(1).BorderColor(Colors.Black);
                    }
                });

                // Đổ dữ liệu
                foreach (var sach in danhSach)
                {
                    table.Cell().Element(CellStyle).Text(sach.MaSach);
                    table.Cell().Element(CellStyle).Text(sach.TieuDe);
                    table.Cell().Element(CellStyle).Text(sach.NamXuatBan.ToString());
                    table.Cell().Element(CellStyle).Text(sach.TacGia?.HoTen ?? sach.TacGiaId.ToString());
                    table.Cell().Element(CellStyle).Text(sach.LoaiSach);
                    table.Cell().Element(CellStyle).Text(sach.HienThiThongTin());

                    static IContainer CellStyle(IContainer container)
                    {
                        return container.BorderBottom(1).BorderColor(Colors.Grey.Lighten2).PaddingVertical(5);
                    }
                }
            });
        }
    }
}