import { products } from './data/products.js';
import { cart } from './vars.js';
import Product from './models/products.js';

export function showProducts(products) {
    let productsContainer = document.querySelector('.products-grid');
    productsContainer.innerHTML = '';

    products.forEach(product => {
        let card = `
        <article class="product">
            <div class="product-header">
                <div class="product-image">
                    <img src="assets/${product.image}.jpg" alt="${product.name}">
                </div>
                <h3>${product.name} (₪${product.price})</h3>
            </div>
            <p>${product.description}</p>
            <button type="button" data-product_id="${product.id}">הוסף לעגלה</button>
        </article>`;

        productsContainer.innerHTML += card;
    });

    //הוספת מאזין אירועים לכל כפתור
    document.querySelectorAll('.product button').forEach(button => {
        button.addEventListener('click', addToCart);
    });
}

export function findProduct(event) {
    event.preventDefault();

    let searchTerm = document.querySelector('#search-input').value;
    let filteredProducts = products.filter(product => {
        return product.name.includes(searchTerm);
    });

    showProducts(filteredProducts);
}

export function addToCart(event) {
    //event.target --> האלמנט הפעיל את האירוע (הכפתור)
    let p_id = event.target.dataset.product_id;
    let product = products.find(p => p.id == p_id);

    if (product) {
        cart.push(product);
        document.querySelector('#cart-count').textContent = cart.length;
        sessionStorage.setItem('cart', JSON.stringify(cart));
        alert(`המוצר "${product.name}" נוסף לעגלה!`);

    }
}

export function showCart() {
    //#cart-items --> אלמנט ה-UL שבו יוצגו פרטי המוצרים בעגלה
    //#cart-summary --> אלמנט שבו יוצג סיכום העגלה (סה"כ לתשלום, כפתור המשך לקופה וכו')

    let cartItemsContainer = document.querySelector('#cart-items');
    cartItemsContainer.innerHTML = '';

    if (cart.length === 0) {
        cartItemsContainer.innerHTML = '<p>העגלה שלך ריקה.</p>';
        return;
    }

    cart.forEach(product => {
        let item = `
        <li class="cart-item">
            <div class="cart-item-image">
                <img src="assets/${product.image}.jpg" alt="${product.name}">
            </div>
            <div class="cart-item-details">
                <h3>${product.name}</h3>
                <p>₪${product.price}</p>
            </div>
        </li>`;

        cartItemsContainer.innerHTML += item;
    });

    let total = cart.reduce((sum, product) => sum + product.price, 0);
    let cartSummary = `
        <p>סה"כ לתשלום: ₪${total}</p>
        <button type="button" id="checkout-button">המשך לקופה</button>`;

    document.querySelector('#cart-summary').innerHTML = cartSummary;
}

export function addProduct(event) {
    event.preventDefault();
    let name = document.querySelector('input[name="product-name"]').value;
    let price = Number(document.querySelector('input[name="product-price"]').value);
    let image = document.querySelector('input[name="product-image"]').value;
    let description = document.querySelector('textarea[name="product-description"]').value;

    let p = new Product(products.length + 1, name, price, image, description);
    products.push(p);
    showProducts(products);

    alert(`המוצר "${p.name}" נוסף בהצלחה!`);
    event.target.reset(); // איפוס הטופס לאחר הוספת מוצר
}