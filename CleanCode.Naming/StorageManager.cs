// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StorageManager.cs" company="bbv Software Services AG">
//   Copyright (c) 2013
//   
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//   
//   http://www.apache.org/licenses/LICENSE-2.0
//   
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
// <summary>
//   Defines the StorageManager type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CleanCode.Naming
{
    /// <summary>
    /// Storage Manager.
    /// </summary>
    public class StorageManager
    {
        /// <summary>
        /// The storage inventory.
        /// </summary>
        private Inventory _i;

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageManager" /> class.
        /// </summary>
        public StorageManager()
        {
            _i = new Inventory();
        }

        /// <summary>
        /// Creates the iteration unit.
        /// </summary>
        public Iterator CreateIterationUnit()
        {
            return new StorageIteratorImpl(_i);
        }

        /// <summary>
        /// Delivers to inventory.
        /// </summary>
        /// <param name="newWeapon">The new weapon.</param>
        public void DeliverToInventory(Weapon newWeapon)
        {
            _i.DeliverToInventory(newWeapon);
        }

        /// <summary>
        /// Takes the last delivered weapon out of the inventory and returns it.
        /// </summary>
        /// <returns>The last delivered weapon.</returns>
        public Weapon TakeFromInventoryPosition()
        {
            Weapon weaponTakenFromLastInventoryPosition = _i.TakeFromInventoryPosition(_i.TheInventory - 1);

            _i.EraseWeaponFromInvetory(_i.TheInventory - 1);

            return weaponTakenFromLastInventoryPosition;
        }
    }
}