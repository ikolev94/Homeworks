function solve(input) {
    var text = input.join('\r\n');
    var regex = /<\s*a\s+([^<>]*\s+)?href\s*=\s*(('([^'>]+)')|("([^">]+)")|([^\s>]+))[^>]*>/g;
    var tags;
    while (tags = regex.exec(text)){

        for (var i = 7; i >= 0; i--) {
            if (tags[i]) {
                console.log(tags[i]);
                break;
            }
        }
    }
}