function knotsConverter(km) {
    var knots = km / 1.852;
    return knots.toFixed(2);
}
console.log(knotsConverter(20));
console.log(knotsConverter(112));
console.log(knotsConverter(400));
