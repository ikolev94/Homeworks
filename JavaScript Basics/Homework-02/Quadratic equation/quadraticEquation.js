var a = prompt('Enter value of a', ''),
    b = prompt('Enter value of b', ''),
    c = prompt('Enter value of c', '');

var rootPart = Math.sqrt(b * b - 4 * a * c);

var root1 = (-b + rootPart) / (2 * a);
var root2 = (-b - rootPart) / ( 2 * a);

if (isNaN(root1) && isNaN(root2)) {
    document.write('No real roots');

} else if (root1 != root2) {
    document.write('1st root: ' + root1 + '<br>');
    document.write('2nd root: ' + root2 + '<br>');
} else if (root1 == root2) {
    document.write('root = ' + root1);
}