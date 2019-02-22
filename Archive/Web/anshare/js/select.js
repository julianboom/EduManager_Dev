function BindSelect(ctrlName, url) {
    var control = $('#' + ctrlName);
    //����Select2�Ĵ���
    control.select2({
        allowClear: true,
        formatResult: formatResult,
        formatSelection: formatSelection,
        escapeMarkup: function (m) {
            return m;
        }
    });

    //��Ajax������
    $.getJSON(url, function (data) {
        control.empty();//���������
        $.each(data, function (i, item) {
            control.append("<option value='" + item.Value + "'>&nbsp;" + item.Text + "</option>");
        });
    });
}