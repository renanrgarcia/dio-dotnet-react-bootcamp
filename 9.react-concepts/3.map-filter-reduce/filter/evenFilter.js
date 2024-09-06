function evenFilter (arr) {
    if (!arr || !arr.length) return;

    const evenArr = arr.filter((evenNumber) => evenNumber % 2 === 0);
    
    return evenArr;
}

console.log(evenFilter([1, 2, 3, 4, 5, 6]));