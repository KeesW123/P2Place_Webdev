class GDPR {
    
    constructor() {
        this.showContent();
        this.bindEvents();

        if (this.cookieStatus() !== 'accept' && this.cookieStatus() !== 'reject') this.showGDPR();
    }

    bindEvents() {
        let buttonAccept = document.querySelector('.gdpr-consent__button--accept');
        buttonAccept.addEventListener('click', () => {
            this.cookieStatus('accept');
            this.showContent();
            this.hideGDPR();
        });
        let buttonReject = document.querySelector('.gdpr-consent__button--reject');
        buttonReject.addEventListener('click', () => {
            this.cookieStatus('reject');
            this.showContent();
            this.hideGDPR();
        });
    }

    showContent() {
        this.resetContent();
        const status = this.cookieStatus() == null ? 'not-chosen' : this.cookieStatus();
        const element = document.querySelector(`.content-gdpr-${status}`);
        element.classList.add('show');
    }

    resetContent() {
        const classes = [
            '.content-gdpr-accept',
            '.content-gdpr-reject',
            '.content-gdpr-not-chosen'];

        for (const c of classes) {
            document.querySelector(c).classList.add('hide');
            document.querySelector(c).classList.remove('show');
        }
    }

    cookieStatus(status) {
        if (status)
            localStorage.setItem('gdpr-consent-choice', status);
        this.saveMetaData();
        return localStorage.getItem('gdpr-consent-choice');
    }

    hideGDPR() {
        document.querySelector(`.gdpr-consent`).classList.add('hide');
        document.querySelector(`.gdpr-consent`).classList.remove('show');
    }

    showGDPR() {
        document.querySelector(`.gdpr-consent`).classList.add('show');
    }

    saveMetaData() {
        const date = new Date();
        let datum = date.getDate() + "-" + date.getMonth() + 1 + "-" + date.getFullYear();
        let tijd = date.getHours() + ":" + date.getMinutes();
        let metadata = { datum, tijd };
        localStorage.setItem("metadata", JSON.stringify(metadata));
    }
}

const gdpr = new GDPR();

