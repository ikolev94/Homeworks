function traverse(selector) {
    var node = document.querySelector(selector);
    traverseNode(node, '');
    function traverseNode(node, spacing) {
        for (var i = 0, len = node.childNodes.length; i < len; i += 1) {
            var child = node.childNodes[i];
            if (child.nodeType === document.ELEMENT_NODE) {
                var nodeName = (child.nodeName).toLowerCase();
                var output = spacing + nodeName + ' : ';
                output += child.id ? 'id=\"' + child.id + '\" ' : '';
                output += child.className ? 'class=\"' + child.className + '\"' : '';
                console.log(output);
                traverseNode(child, spacing + '  ');
            }
        }
    }
}

traverse('.birds');
console.log();