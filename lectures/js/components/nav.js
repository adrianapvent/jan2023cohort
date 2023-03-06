class Nav extends HTMLElement {
    constructor() {
        super();
    }

    connectedCallback() {
        this.innerHTML = `
                <nav>
                    <a href="./index.html">Home</a>
                    <a href="./bear.html">Bear Memorial Page</a>
                    <a href="./iBee-lieve.html">I Bee-lieve Buttons</a>
                    <a href="./lectures.html">Class Lectures</a>
                    <a href="#">Class Notes</a>
                    <a href="#">Class Projects</a>
                </nav>
        `;
    }
}

customElements.define('nav-component', Nav);