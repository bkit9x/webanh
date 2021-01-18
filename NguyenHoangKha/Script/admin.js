function modalEdit(id, link) {
    document.getElementById('EditLink').value = link;
    document.getElementById('EditId').value = id;
    var myModal = new bootstrap.Modal(document.getElementById('EditModal'));
    myModal.show();
}
function modalDelete(id) {
    document.getElementById('DeleteId').value = id;
    var myModal = new bootstrap.Modal(document.getElementById('DeleteModal'));
    myModal.show();
}
