import {useState} from 'react'

function ToDoForm({addTask}){
	const [userInput,setUserInput]=useState('')

	const handlechange=(e)=>{
		setUserInput(e.currentTarget.value)
	}

	const handleSubmit=(e)=>{
		e.preventDefault()
		addTask(userInput)
		setUserInput("")
	}

	const handleKeyPress=(e)=>{
		if(e.key==="Enter"){
			handleSubmit(e);
		}
	}

	return(
		<form onSubmit={handleSubmit}>
			<input
			value={userInput}
			type="text"
			onChange={handlechange}
			onKeyDown={handleKeyPress}
			placeholder='Введите значение...'
			></input>
			<button>Создать</button>
		</form>
	)
}

export default ToDoForm