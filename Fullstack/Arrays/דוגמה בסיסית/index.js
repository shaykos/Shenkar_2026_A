let arr = new Array(1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 5, 7);

let multi = arr.reduce((prev, cur) => prev * cur); //35840
console.log(multi);

let sum = arr.reduce((prev, cur) => prev + cur); //33
console.log(sum);

console.log(arr.join(", "));