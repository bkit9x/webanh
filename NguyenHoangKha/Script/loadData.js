is_busy = false;
$(document).ready(function () {
    $element = $('#content');
    $.ajax(
        {
    type: 'get',
            dataType: 'html',
            url: 'load.aspx',
            success: function (result) {
    $element.append(result);
            }
        });



    $('#load_more').click(function () {
    $element = $('#content');
        $button = $(this);
        if (is_busy == true) {
            return false;
        }
        $button.html('Đang Tải...');
        is_busy == true;
        $.ajax(
            {
    type: 'get',
                dataType: 'html',
                url: 'load.aspx',
                success: function (result) {
    $element.append(result);
                }
            })
            .always(function () {
    $button.html('Xem Thêm Còn Nhiều Lắm');
                is_busy = false;
            });

    });
});
