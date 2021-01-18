<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="NguyenHoangKha.admin" %>

<!DOCTYPE html>
<html lang="en" class="">

<head>
    <meta charset="utf-8">
    <meta name="robots" content="noindex, nofollow">
    <title>Admin</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-giJF6kkoqNQ00vy+HMDP7azOuL0xtbfIcaT9wjKHr8RbDVddVHyTfAAsrekwKmP1" crossorigin="anonymous">
    <link href="Content/StyleSheet.css" rel="stylesheet" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>  
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-ygbV9kiqUc6oa4msXn9868pTtWMgiQaeYH7/t7LECLbyPA2x65Kgf80OJFdroafW" crossorigin="anonymous"></script>    <script src="https://cdn.datatables.net/1.10.23/js/jquery.dataTables.min.js"></script>
    <script src="https://cdn.datatables.net/1.10.23/js/dataTables.bootstrap4.min.js"></script>
    <script src="Script/admin.js"></script>
</head>

<body>
    <nav class="navbar navbar-dark px-5 fixed-top">
      <a class="navbar-brand" href="#">NguyenHoangKha</a>
    </nav>
    <div class="container page-top">
    <table id="example" class="table table-dark table-bordered" style="width:100%">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Link</th>
                    <th>Image</th>
                    <th>Edit</th>
                </tr>
            </thead>
            <tbody>
                <asp:Literal ID="ltrTable" runat="server"></asp:Literal>
            </tbody>
        </table>
    </div>
    <!-- Edit -->
    <div class="modal fade" id="EditModal" tabindex="-1" aria-labelledby="EditModal" aria-hidden="true">
      <div class="modal-dialog">
        <div class="modal-content">
          <div class="modal-header">
            <h5 class="modal-title" id="EditModalLabel">Chỉnh sửa</h5>
            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
          </div>
          <div class="modal-body">
            <form method="post" action="" name="edit" id="edit">
              <div class="form-group">
                <label for="EditLink">Link</label>
                <input type="url" class="form-control" id="EditLink" name="link" placeholder="Enter Link">
              </div>
                <input type="hidden" class="form-control" id="EditId" name="id">
            </form>
          </div>
          <div class="modal-footer">
            <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Hủy</button>
            <button type="submit" name="button_edit" form="edit" class="btn btn-primary">Lưu thay đổi</button>
          </div>
        </div>
      </div>
    </div>

    <!-- Delete -->
    <div class="modal fade" id="DeleteModal" tabindex="-1" aria-labelledby="DeleteModal" aria-hidden="true">
      <div class="modal-dialog">
        <div class="modal-content">
          <div class="modal-header">
            <h5 class="modal-title" id="DeleteModalLabel">Bạn thực sự muốn xóa?</h5>
            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
          </div>
          <div class="modal-footer">
            <form method="post" action="" name="Delete">
                <input type="hidden" class="form-control" id="DeleteId" name="id">
                <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Hủy</button>
                <button type="submit" name="button_Delete" form="Delete" class="btn btn-danger">Xóa</button>
            </form>
          </div>
        </div>
      </div>
    </div>
    <script>
        $(document).ready(function () {
            $('#example').DataTable();
        });
    </script>
</body>
</html>