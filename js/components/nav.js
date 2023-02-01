class Nav extends HTMLElement {
    constructor() {
        super();
    }

    connectedCallback() {
        this.innerHTML = `
                <nav>
                    <a href="./index.html">Home</a>
                    <a href="./bear.html">Bear Memorial Page</a>
                    <a href="#">Class Lectures</a>
                    <a href="#">Class Notes</a>
                    <a href="./lectures/webFundamentals/index.html">Web Fundamental Pages</>
                    <a href="#">1 stack class project</>
                </nav>
        `;
    }
}

customElements.define('nav-component', Nav);