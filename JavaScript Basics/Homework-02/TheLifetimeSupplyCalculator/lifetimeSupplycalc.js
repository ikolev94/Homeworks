function calcSupply(age, maxAge, food, foodPerDay) {
    var yearsLeft = maxAge - age;
    var result = yearsLeft*365*foodPerDay;
    return result +'kg of '+food+' would be enough until I am '+maxAge+' years old.'
}

console.log(calcSupply(38,118,'chocolate',0.5));
console.log(calcSupply(20,87,'fruits',2));
console.log(calcSupply(16,102,'nuts',1.1));