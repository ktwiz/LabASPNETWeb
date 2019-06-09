import App from './App.js';

console.log('ES6 Running');

const renderPage = () => {
    const rootEl = document.getElementById("root");
    const app = new App();
    rootEl.innerHTML = app.render();    
};

renderPage();