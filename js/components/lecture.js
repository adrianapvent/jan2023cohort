class Lecture extends HTMLElement {
    constructor() {
        super();
    }

    connectedCallback() {
        this.innerHTML = `
                <header>
                    <nav>
                        <a href="../../index.html">Home</a>
                        <a href="../../bear.html">Bear Memorial</a>
                    </nav>
                    <nav>
                        <a href="./lectures/webFundamentals/week1/day1/index.html" target="_blank">Week 1 Day 1</a>
                    </nav>
                </header>
        `;
    }
}

customElements.define('lecture-component', Lecture);