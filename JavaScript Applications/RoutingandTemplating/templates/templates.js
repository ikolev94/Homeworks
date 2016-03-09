(function () {
    var data, table;
    data = {
        'people': [
            {'name': 'Kiro', 'job': 'Kopach', 'website': 'www.kiro.com'},
            {'name': 'Penka', 'job': 'Perach', 'website': 'www.penka.org'},
            {'name': 'Joro', 'job': 'Orach', 'website': 'www.google.com'},
            {'name': 'Rangel', 'job': 'Metach', 'website': 'www.metem.com'},
            {'name': 'Sisi', 'job': 'Sekach', 'website': 'www.sisity.com'}
        ]
    };
    $.get('tableTemplate.html', function (template) {
        table = Mustache.to_html(template, data);
        $('#wrapper').html(table);
    })
}());