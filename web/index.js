function regSearch(r, s) {
    var reg = new RegExp(r, 'g')
    var ls = []
    while ((m = reg.exec(s)) != null) {
        ls.push(m[0])
    }
    return ls
}
function eachReg(r, s, func) {
    var reg = new RegExp(r, 'g')
    while ((m = reg.exec(s)) != null) {
        func(m[0])
    }
}