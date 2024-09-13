import { useState } from "react";
import { Header } from "../../components/Header";
import ItemList from "../../components/ItemList";
import background from "../../assets/background.png";
import "./styles.css";

function App() {
  const [user, setUser] = useState('');
  const [currentUser, setCurrentUser] = useState(null);
  const [repositories, setRepositories] = useState(null);

  const handleSearch = async () => {
    const userData = await fetch(`https://api.github.com/users/${user}`);
    const newUser = await userData.json();
    
    if (newUser.name) {
      const {avatar_url, name, bio, login} = newUser;
      setCurrentUser({avatar_url, name, bio, login});
      
      const repositoriesData = await fetch(`https://api.github.com/users/${user}/repos`);
      const newRepositories = await repositoriesData.json();

      if (newRepositories.length) {
        setRepositories(newRepositories);
      }
    }
  }

  return (
    <div className="App">
      <Header />
      <div className="content">
        <img src={background} className="background" alt="background" />
        <div className="info">
          <div>
            <input 
            name="user" 
            value={user} 
            onChange={(event) => setUser(event.target.value)} 
            placeholder="@username" />
            <button onClick={handleSearch}>Search</button>
          </div>
          {currentUser?.name ? (
          <>
            <div className="profile">
            <img src={currentUser.avatar_url} className="profile-image" alt="" />
              <div>
                <h3>{currentUser.name}</h3>
                <span>@{currentUser.login}</span>
                <p>{currentUser.bio}</p>
              </div>
            </div>
            <hr/>
          </>
          ) : null}
          
          {repositories?.length ? (
            <>
              <div>
                <h4 className="repository">Repositories</h4>
                {repositories.map((repository) => (
                  <>
                    <ItemList title={repository.name} description={repository.description} />
                  </>
                ))}
                
              </div>
            </>
          ) : null}
        </div>
      </div>
    </div>
  );
}

export default App;