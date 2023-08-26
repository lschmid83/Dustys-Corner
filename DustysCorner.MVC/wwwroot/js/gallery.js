$(document).ready(function () {

    hideImageTooltip();

    function hideImageTooltip() {
        $('.gallery-image').hover(function () {
            var title = $(this).attr('title');
            $(this).attr('tmp_title', title);
            $(this).attr('title', '');
        });

        $('.gallery-image').click(function () {
            var title = $(this).attr('tmp_title');
            $(this).attr('title', title);
        });
    }
});
