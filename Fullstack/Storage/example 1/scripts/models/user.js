export default class User {

    constructor(name, age) {
        this.Name = name;
        this.Age = age;
    }

    set Name(value) { this.name = value; }
    get Name() { return this.name; }

    set Age(value) { this.age = value; }
    get Age() { return this.age; }
}