export default class Product {
    constructor(id, name, price, image, description) {
        this.id = id;
        this.name = name;
        this.price = price;
        this.image = image; // שם קובץ התמונה ללא סיומת 
        this.description = description;
    }
}