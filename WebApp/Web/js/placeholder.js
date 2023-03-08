function CreateExampleView()
{
    const body = document.getElementById('funny')

    let funText = document.createElement('h3')


    temp = 'This text is generated'

    body.appendChild(funText)
    
    funText.innerHTML = temp
}