const orange = {
    price : 2,
}

const apple = {
    price : 3,
}

function multiply (arr, fruit) {
    if (!arr || !arr.length) return;

    const multArr = arr.map(function (item) {
        return item * this.price;
    }, fruit);

    return multArr;
}

console.log(multiply([1, 2, 3, 4, 5], orange));
console.log(multiply([1, 2, 3, 4, 5], apple));