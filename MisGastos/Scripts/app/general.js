function bindForm(options) {

    var $container = $(options.selector);

    $container.submit(function (e) {

        options.beforeLoad && options.beforeLoad();
        if (options.validateForm && options.validateForm()) {
            options.beforeSubmit && options.beforeSubmit(function () {
            });
            return true;
        }
        else {
            e.preventDefault();
        }
    });
}

function validateFieldRequired(selector) {
    return $(selector).val();
}