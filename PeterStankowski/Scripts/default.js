$(function () {

    // divider click event and icon toggle
    var dividerIconClass = 'fa-compress';

    $('.layout-divider').click(function () {
        $('.layout').toggleClass('collapsed');

        toggleIcon($(this).find('.fa'), $('.layout').hasClass('collapsed'));
    });

    function toggleIcon($icon, isCollapsed) {
        if (isCollapsed) {
            $icon.removeClass(dividerIconClass);
            $icon.addClass('fa-expand');
        } else {
            $icon.addClass(dividerIconClass);
            $icon.removeClass('fa-expand');
        }
    }

    var windowWidth=0;
    function toggleSidebar(collapse) {
        if (collapse) {
            if (windowWidth != deviceWidth) {
                if (!$('.layout').hasClass('collapsed')) {
                    $('.layout-divider').trigger('click');
                }
            }
        } else {
            if (windowWidth != deviceWidth) {
                if ($('.layout').hasClass('collapsed')) {
                    $('.layout-divider').trigger('click');
                }
            }
        }
        windowWidth = $(window).width();
    }

    // sidebar auto-collapse
    var autocollapseWidth = 1230;
    var deviceWidth = $(window).width();
    if (deviceWidth <= autocollapseWidth) {
        toggleSidebar(true);
    }
    $(window).resize(function () {
        if ($(window).width() <= autocollapseWidth) {
            toggleSidebar(true);
        } else {
            toggleSidebar(false);
        }
    });
});