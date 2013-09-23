fameapp.HomeController = Ember.Controller.extend({
    message: 'Welcome to this app!',
    init: function () {

        console.log("init HomeController");

        require(['framework'], function (JQD) {

            JQD.go();

        });

    }
});