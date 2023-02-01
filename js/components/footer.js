class Footer extends HTMLElement {
    constructor() {
        super();
    }

    connectedCallback() {
        this.innerHTML = `
            <footer>
                <h3>The Ladies of the January Cohort</h3>
            </footer>
        `;
    }
}

customElements.define('footer-component', Footer);