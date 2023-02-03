class Lecture extends HTMLElement {
    constructor() {
        super();
    }

    connectedCallback() {
        this.innerHTML = `
            <ol>
                <li><a href="./lectures/programmingBasics/index.html">Programming Basics</a></li>
                <li><a href="./lectures/webFundamentals/index.html">Web Fundamentals</a></li>
                <li><a href="./lectures/cSharp/index.html">C#</a></li>
                <li><a href="./lectures/java/index.html">Java</a></li>
            </ol>
        `;
    }
}

customElements.define('lecture-component', Lecture);