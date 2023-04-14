class AdvertCard extends HTMLElement {
    constructor() {
        super();
    }

    connectedCallback() {
        // browser calls this method when the element is added to the document
        // (can be called many times if an element is repeatedly added/removed)
        this.innerHTML = '<div class="card"><img src="~/images/p2place_logo.png"><div class="advert-text"><b>John Doe</b><p>Architect & Engineer</p></div></div>';
    }

    disconnectedCallback() {
        // browser calls this method when the element is removed from the document
        // (can be called many times if an element is repeatedly added/removed)
    }

    static get observedAttributes() {
        return [/* array of attribute names to monitor for changes */];
    }

    attributeChangedCallback(name, oldValue, newValue) {
        // called when one of attributes listed above is modified
    }
}

// let the browser know that <my-element> is served by our new class
customElements.define("advert-card", AdvertCard);

// All adverts should be displayed by looping through every created advert in the database. All adverts should get created in a custom element called "advert-card" with the values according to the database.
// At last all these elements should be added to a container on the index page so everyone can see the adverts.