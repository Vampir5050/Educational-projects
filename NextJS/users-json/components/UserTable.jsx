import React, { useEffect, useState } from 'react';
import UserRow from './UserRow';
import styles from '../styled-components/UserTable.module.css';

const UserTable = () => {
  const [users, setUsers] = useState([]);

  useEffect(() => {
    fetch('https://jsonplaceholder.typicode.com/users')
      .then((response) => response.json())
      .then((data) => setUsers(data));
  }, []);

  return (
    <table className={styles.table}>
      <thead>
        <tr>
          <th>Имя</th>
          <th>Email</th>
          <th>Город</th>
          <th>Телефон</th>
          <th>Веб-сайт</th>
          <th>Компания</th>
        </tr>
      </thead>
      <tbody>
        {users.map((user) => (
          <UserRow key={user.id} user={user} />
        ))}
      </tbody>
    </table>
  );
};

export default UserTable;
