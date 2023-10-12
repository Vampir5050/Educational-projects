import React from 'react';
import styles from '../styled-components/UserRow.module.css';

const UserRow = ({ user }) => {
  return (
     <tr className={styles.row}>
      <td>{user.name}</td>
      <td>{user.email}</td>
      <td>{user.address.city}</td>
      <td>{user.phone}</td>
      <td>{user.website}</td>
      <td>{user.company.name}</td>
    </tr>
  );
};

export default UserRow;
