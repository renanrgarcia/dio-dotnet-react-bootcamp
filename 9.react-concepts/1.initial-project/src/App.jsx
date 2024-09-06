import React, { useState, useEffect } from "react";

const App = () => {
    const [user, setUser] = useState("");
    const [count, setCount] = useState(0);
    const [users, setUsers] = useState(
        ["Renan", "Thaís"]
    );
    
    const handleUser = () => {
        setUsers([...users, user]);
        setUser("");
    }

    useEffect(() => {
        setCount(users.length);
    }, [users]);

    // useEffect(() => {
    //     setTimeout(() => {
    //         setUsers([...users, "Aurora", "Pedro"]);
    //     }, 3000);
    // }, []);

    return (
        <div className="App">
            <h1>Hello React</h1>
            <h3>Count: {count}</h3>
            <div>
                <input 
                    value={user}
                    onChange={(event) => setUser(event.target.value)}
                />
                <button onClick={handleUser}>Add</button>
            </div>

            {users.map((user) => (
                <p>{user}</p>
            ))}
        </div>
    );
};

export default App;