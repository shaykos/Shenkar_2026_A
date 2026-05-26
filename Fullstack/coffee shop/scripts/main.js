import { products } from './data/products.js';
import { showProducts, findProduct, showCart, addProduct } from './functions.js';
import { cart } from './vars.js';

document.querySelector('#cart-count').textContent = cart.length;

if (location.pathname == '/' || location.pathname.endsWith('index.html')) {
    document.addEventListener('DOMContentLoaded', () => {
        showProducts(products);

        const cartCountElement = document.querySelector('#cart-count');
        if (cartCountElement) {
            cartCountElement.textContent = cart.length;
        }
    });

    document.querySelector('#search-form').addEventListener('submit', findProduct);

    document.querySelector('#search-input').addEventListener('input', findProduct);

    document.querySelector('.product-form').addEventListener('submit', addProduct);
}

if (location.pathname.endsWith('cart.html')) {
    document.addEventListener('DOMContentLoaded', showCart);
}


