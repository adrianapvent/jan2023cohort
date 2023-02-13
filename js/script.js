const gitUrl = 'https://api.github.com/repos/partnershipPrograms-instructorMelissa/jan2023cohort/forks'


async function getForks() {
    let res = await fetch(`${gitUrl}`)
    let data = await res.json()
    console.log(data)
    let test = data[0].owner
    console.log(test)
    // owner.avatar_url = img
    // owner.html_url = a link back to user profile
    // html_url = repo link
    // owner.login = username
    for(let i = 0; i < data.length; i++) {
        var node = document.createElement('div')
        var h2 = document.createElement('h2')
        var h3 = document.createElement('h3')
        var img = new Image()
        var a  = document.createElement('a')
        var aa = document.createElement('a')
        var name = document.createTextNode(data[i].owner.login)
        node.setAttribute('class', 'git')
        img.src = `${data[i].owner.avatar_url}`
        img.alt = `${data[i].owner.login}`
        a.setAttribute("href", data[i].owner.html_url)
        a.setAttribute("target", "_blank")
        aa.setAttribute("href", data[i].html_url)
        aa.setAttribute("target", "_blank")
        aa.append("Repo Link")
        a.appendChild(name)
        h2.appendChild(a)
        h3.appendChild(aa)
        node.appendChild(img)
        node.appendChild(h2)
        node.appendChild(h3)
        document.getElementById('forks').appendChild(node)
    }
}