function sortLetters(word, ascending) {

    function ascendingComp(str1, str2, ascending) {
        return str1.toLowerCase().localeCompare(str2.toLowerCase());
    }
    function descendingComp(str1, str2, ascending) {
        return -str1.toLowerCase().localeCompare(str2.toLowerCase());
    }

    word = word.split('');
    if (ascending) {
         console.log(word.sort(ascendingComp).join(''));
    } else {
        console.log(word.sort(descendingComp).join(''));
    }
}

sortLetters('HelloWorld', true);
sortLetters('HelloWorld', false);