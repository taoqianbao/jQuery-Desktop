fameapp.AboutController = Ember.Controller.extend({
    message: 'About this app.',
    init: function () {

        console.log("init AboutController");

        console.log($("#window_network").html());

        $("#window_network").show();

    }
});