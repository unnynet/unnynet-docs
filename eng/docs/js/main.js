// Handle code tabs
this.Tabs = (function () {
    Tabs.prototype.navTabs = null;
    Tabs.prototype.panels  = null;

    function Tabs(elem) {
        this.navTabs = elem.getElementsByClassName('nav-item');
        this.panels  = elem.getElementsByClassName('tab-pane');
        this.bind();
    };
    Tabs.prototype.show = function (index) {
        var activePanel, activeTab;
        for (var i = 0, l = this.navTabs.length; i < l; i++) {
            this.navTabs[i].classList.remove('active');
        }
        activeTab = this.navTabs[index];
        activeTab.classList.add('active');
        for (var i = 0, l = this.panels.length; i < l; i++) {
            this.panels[i].classList.remove('active');
        }
        activePanel = this.panels[index];
        return activePanel.classList.add('active');
    };
    Tabs.prototype.bind = function () {
        var _this = this;
        for (var i = 0, l = this.navTabs.length; i < l; i++) {
            (function (elem, index) {
                elem.addEventListener('click', function (evt) {
                    evt.preventDefault();
                    return _this.show(index);
                });
            })(this.navTabs[i], i);
        }
    };
    return Tabs;
})();

document.addEventListener('DOMContentLoaded', function () {
    const nodes = document.getElementsByClassName('code-nav-container');
    for (let i = 0, l = nodes.length; i < l; i++) {
        new Tabs(nodes[i]);
    }
});

const supportedLanguages = ['ru', 'en'];
const localizations      = {
    ru: 'Русский',
    en: 'English'
};

function onLanguageChanged(e) {
    const href        = window.location.href;
    const iStart      = href.indexOf('//');
    const iEnd        = href.indexOf('.');
    const curLanguage = href.substr(iStart + 2, iEnd - iStart - 2);
    const newLanguage = e.target.value;

    if (newLanguage === curLanguage)
        return;

    window.location = href.substr(0, iStart + 2) + newLanguage + href.substr(iEnd);
}

function initLanguagePanel() {
    const languages = document.getElementById('languages_block');

    const selectList = document.createElement('select');
    for (const lng of supportedLanguages) {
        const option = document.createElement('option');
        option.value = lng;
        option.text  = localizations[lng];
        selectList.appendChild(option);
    }

    selectList.onchange = onLanguageChanged;

    languages.appendChild(selectList);

    const href       = window.location.href;
    const iStart     = href.indexOf('//');
    const iEnd       = href.indexOf('.');
    selectList.value = href.substr(iStart + 2, iEnd - iStart - 2);
}

initLanguagePanel();