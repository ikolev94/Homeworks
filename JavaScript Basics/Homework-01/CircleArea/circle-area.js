function calcCircleArea(r) {
    return r * r * Math.PI;
}

document.getElementsByClassName('first')[0].innerHTML = calcCircleArea(7);
document.getElementsByClassName('second')[0].innerHTML = calcCircleArea(1.5);
document.getElementsByClassName('third')[0].innerHTML = calcCircleArea(20);