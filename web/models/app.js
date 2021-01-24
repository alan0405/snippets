var boot = window.external;
var app = {
    path: '',
    files: [],
    msgs: [],
    content: '',
    snippet: undefined,
    selected: undefined,
    load: function () {
        if (app.path == undefined) return;
        var files = boot.GetFiles(app.path);
        if (files != '') {
            files = JSON.parse(files);
            files.forEach(function (file) {
                file.select = false;
                app.decode(file);
            });
            app.files = files;
        }
    },
    encode: function (file) {
        var content = {}
        file.snippets.forEach(function (snpt) {
            var copySnpt = JSON.parse(JSON.stringify(snpt))
            copySnpt.body = copySnpt.body.split('\n');
            content[snpt.prefix] = copySnpt
        });

        return JSON.stringify(content);
    },
    decode: function (file) {
        file.snippets = [];
        file.isEdit = false;
        var snpts = JSON.parse(file.content);
        for (var key in snpts) {
            if (snpts.hasOwnProperty(key)) {
                var snpt = snpts[key];
                snpt.body = snpt.body.join(" \n");
                file.snippets.push(snpt)
            }
        }

    },
    save: function (file) {
        file = file || app.selected;
        file.isEdit = false;
        var content = app.encode(file);
        if (boot.SaveFile(app.path + '/' + file.name, content)) {
            app.showMsg("file " + file.name + ' saved!')
        }
        var res = boot.Backup('../backup/' + file.name, content);

        if (res == 'OK') {
            app.showMsg("file " + file.name + ' backuped!')
        }
    },
    backup: function () {
        app.files.forEach(function (file) {
            var content = app.encode(file);
            var res = boot.Backup('../backup/' + file.name, content);
            if (res == 'OK') {
                app.showMsg("file " + file.name + ' backuped!')
            }
        });
    },
    restore: function () {
        var res = boot.Restore('../backup');
        if (res == undefined || res == '') {
            app.showMsg('failed to restore!');
        }
        var files = JSON.parse(res);
        files.forEach(function (file) {
            app.decode(file);
            file.select = false;
            file.isEdit = false;
            app.save(file);

        });
        app.files = files;
    },
    select: function (file) {
        file.select = !file.select;
        if (file.select) {
            if (app.selected) app.selected.select = false;
            app.selected = file;
        } else {
            app.selected = undefined;
            app.snippet = undefined;
        }
    },
    deleteSnippet: function (snpt) {
        if (app.snippet == snpt) {
            app.snippet = undefined;
        }
        app.selected.snippets.splice(app.selected.snippets.indexOf(snpt), 1);
    },
    showMsg: function (content) {
        app.msgs.push(content);
        setTimeout(function () {
            app.msgs.pop();
        }, 1000);
    }
}
app.path = boot.GetSnippetPath();
app.load();
boot.SetWindowPos(-1, 0, 900, 900);