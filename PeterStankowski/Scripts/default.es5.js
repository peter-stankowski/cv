'use strict';

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
    function toggleSidebar(collapse) {
        var windowWidth = $(window).width();

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
    }
    // sidebar auto-collapse
    var autocollapseWidth = 1230;
    var deviceWidth = window.width();
    $(window).resize(function () {
        alert("hi");
        if ($(window).width() <= autocollapseWidth) {
            toggleSidebar(true);
        } else {
            toggleSidebar(false);
        }
    });
});

