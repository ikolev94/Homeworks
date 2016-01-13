function replaceATag(str) {
    var regex = /<a href=(.+?)>([^<]+)<\/a>/g;
    var result = [];
    var match;
    while (match = regex.exec(str)) {
        result.push(match[1]);
    }
    return result.join('');
}

var checkValue = '<p>Hello</p><a href=\'http://w3c.org\'>W3C</a>';
console.log(replaceATag(checkValue));