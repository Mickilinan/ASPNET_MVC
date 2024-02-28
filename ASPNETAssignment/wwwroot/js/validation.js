
const formErrorHandler = (e, validationResult) => {
    let element = document.querySelector(`[data-valmsg-for="${e.taget.name}"]`)

    if (validationResult) {
        e.target.classlist.remove('input-validation-error')
        spanElement.classlist.remove('field-validation-error')
        spanElement.classlist.add('field-validation-valid')
        spanElemt.innerHTML = ''
    }
    else {
        e.target.classlist.add('input-validation-error')
        spanElement.classlist.add('field-validation-error')
        spanElement.classlist.remove('field-validation-valid')
        spanElemt.innerHTML = e.target.dataset.valRequired

    }
}


const compareValidator = (element, compareWithValue) => {
    if (element === compareWithValue)
        return true

    return false

}

const textValidator = (element, minLength = 2) => {
    if (element.value.length >= minLength)

        formErrorHandler(element, true)

    formErrorHandler(element, false)


}

const emailValidator = (element) => {
    const regEx = /^(([^<>()[\]\.,;:\s@\"]+(\.[^<>()[\]\.,;:\s@\"]+)*)|(\".+\"))@(([^<>()[\]\.,;:\s@\"]+\.)+[^<>()[\]\.,;:\s@\"]{2,})$/
    formErrorHandler(element, regEx.test(element.value))
}


const passwordValidator = (element) => {

    if (element.dataset.valEqualToOther !== undefined) {
        formErrorHandler(element, compareValidator(element.value, document.getElementsByName(elemnt.dataset.valEqualToOther.replace('*', 'Form'))[0].value))
    } else {
        const regEx = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[#$@!%&*?])[A-Za-z\d#$@!%&*?]{8,30}$/
        formErrorHandler(element, regEx.test(element.value))

    }
}


const checkboxValidator = (element) => {

    if (element.checked)
        formErrorHandler(element, true)

    formErrorHandler(element, false)
}

let forms = document.querySelector('form')
let inputs = forms[0].querySelectorAll('input')


inputs.forEach(input => {
    if (input.dataset.val === 'true') {

        if (input.type === 'checkbox') {
            input.addEventListener
        }
    }
})
   

