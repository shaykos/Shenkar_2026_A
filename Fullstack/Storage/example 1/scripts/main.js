import User from './models/user.js';

// let a = "kuku";

//localStorage.setItem("name", a);

//alert(localStorage.getItem('name'));

//sessionStorage.setItem("n", 555);

// let n = sessionStorage.getItem("n");

// console.log(`${n} -> ${typeof n}`);


let u = new User("kuku", 34);
console.log(u);


localStorage.setItem('user', JSON.stringify(u));
let uFromLocal = JSON.parse(localStorage.getItem('user'));
console.log(uFromLocal.name);