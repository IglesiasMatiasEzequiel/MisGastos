class ValidationSummary {

    constructor(id) {

        this.id = id;
        this.validationSummaryId = this.id ? this.id : "";
        this.validationSummaryClass = "validationSummary";
        this.validationSummaryTitleClass = "validationSummaryTitle";
        this.validationSummaryContentClass = "validationSummaryContent";

        /* Selectores */

        this.validationSummarySelector = this.validationSummaryId + "." + this.validationSummaryClass;
        this.validationSummaryTitleSelector = this.validationSummaryId + "." + this.validationSummaryTitleClass;
        this.validationSummaryContentSelector = this.validationSummaryId + "." + this.validationSummaryContentClass;

        /* Contenedore */

        this.$validationSummary = $(this.validationSummarySelector);
        this.$validationSummaryTitle = $(this.validationSummarySelector, this.validationSummaryTitleSelector);
        this.$validationSummaryContent = $(this.validationSummarySelector, this.validationSummaryContentSelector);

        this.initialize();
    }

    /* Funciones */

    initialize() {
        if (this.$validationSummary) {
            this.$validationSummary.hide();
            this.$validationSummary.html("");
        }
    }

    show(options, callback) {

        var title = options.title || "Se han encontrado los siguientes errores: ";
        var list = options.list || new [];

        if (!this.$validationSummaryTitle.length) {
            this._createTitle(title);
        }

        if (!this.$validationSummaryContent.length) {
            this._createContent(list);
        }

        this.$validationSummary.show();

        callback && callback();
    }

    _createTitle(title) {
        this.$validationSummary.append("<span " + this._addClass(this.validationSummaryTitleClass) + ">" + title + "</span>");
    }

    _createContent(list) {

        var html = "<div " + this._addClass(this.validationSummaryContentClass) + "><ul>";

        for (var i = 0; i < list.length; i++) {
            html += this._addListItem(i, list[i]);
        }

        html += "</ul></div>";

        this.$validationSummary.append(html);
    }

    _addProperty(propertyName, propertyValue) {
        return propertyName + " = \"" + propertyValue + "\"";
    }

    _addId(id) {
        return this._addProperty("id", id);
    }

    _addClass(className) {
        return this._addProperty("class", className);
    }

    _addListItem(i, content) {

        var id = this.validationSummaryContentClass + "_li_" + i;

        return "<li " + this._addId(id) + ">" + content + "</li>";
    }

}