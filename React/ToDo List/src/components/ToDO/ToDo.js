function ToDo({todo,toggleTask,removeTask}){
	return(
		<div key={todo.id} className="item-todo">
			 <input type='checkbox' onChange={()=>toggleTask(todo.id)}></input>
			<div className={todo.complete ? "item-text strike" : "item-text"}>
				{todo.task}
			</div>
			<div className='item-delete' onClick={()=>removeTask(todo.id)}>
					&#10060;
			</div>
		</div>
	)
}

export default ToDo