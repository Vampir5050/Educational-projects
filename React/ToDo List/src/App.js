import {useState} from 'react'
import ToDo from './components/ToDO/ToDo';
import ToDoForm from './components/ToDO/ToDoForm';


function App() {
	const[todos, setTodos]=useState([])
	
	const addTask =(userInput)=>{
		if(userInput){
			const newItem={
				id: Math.random().toString(36).substring(2,9),
				task:userInput,
				complete:false
			}
			setTodos([...todos,newItem])
		}
	}
	const removeTask = (id)=>{
		setTodos([...todos.filter((todo)=>todo.id!==id)])
	}

	const removeTaskComplete=()=>{
		setTodos([...todos.filter((todo)=>todo.complete===false)])
	}
	const handleToggle = (id)=>{
		setTodos([...todos.map((todo)=>
			todo.id===id?{...todo,complete:!todo.complete}:{...todo})])
	}
	
  return (
    <div className="App">
    <header>
		<h1>Мои дела: {todos.length}</h1>
	</header>
	<ToDoForm addTask={addTask} />
	{todos.map((todo)=>{
		return(
			<ToDo
			todo={todo}
			 key={todos.id}
			 toggleTask={handleToggle}
			 removeTask={removeTask}/>
		)
	})
	}
	<button className='removComplete' onClick={()=>removeTaskComplete()} > Удалить выполненные &#10060;</button>
    </div>
  );
}

export default App;
