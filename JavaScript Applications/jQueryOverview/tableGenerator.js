$.makeTable = function (mydata) {
    var table = $('<table border=1>');
    var tblHeader = "<tr style='background: lawngreen'>";
    for (var k in mydata[0]) tblHeader += "<th>" + k + "</th>";
    tblHeader += "</tr>";
    $(tblHeader).appendTo(table);
    $.each(mydata, function (index, value) {
        var TableRow = "<tr>";
        $.each(value, function (key, val) {
            TableRow += "<td>" + val + "</td>";
        });
        TableRow += "</tr>";
        $(table).append(TableRow);
    });
    return ($(table));
};

var data = [{"manufacturer": "BMW", "model": "E92 320i", "year": 2011, "price": 50000, "class": "Family"},
    {"manufacturer": "Porsche", "model": "Panamera", "year": 2012, "price": 100000, "class": "Sport"},
    {"manufacturer": "Peugeot", "model": "305", "year": 1978, "price": 1000, "class": "Family"}];

var table = $.makeTable(data);
$('#problem3').append($('<h1>').text('3. Table Generator')).append(table);
