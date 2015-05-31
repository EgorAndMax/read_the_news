if (annyang) {

    annyang.setLanguage('ru');

    var commands = {
        'привет': function () {
            alert("привет");
        }
    };

    annyang.addCommands(commands);

    annyang.start();
}