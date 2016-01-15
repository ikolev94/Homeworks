function replaceATag(str) {
    var regex = /<a href=(.+?)>([^<]+)<\/a>/gi;
    var result = [];
    var match;
    while (match = regex.exec(str)) {
        console.log('[URL href=' + match[1] + ']' + match[2] + '[/URL]');
    }
    //return result.join('');
}

var checkValue = '<ul> <li> <a href=http://softuni.bg>SoftUni</a></li></ul>';
replaceATag(checkValue);